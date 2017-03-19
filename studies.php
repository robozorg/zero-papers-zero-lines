<html>
<head>
<script
  src="https://code.jquery.com/jquery-3.1.1.min.js"
  integrity="sha256-hVVnYaiADRTO2PzUGmuLJr8BLUSjGIZsDYGmIJLv2b8="
  crossorigin="anonymous"></script>

    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

<!-- Optional theme -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
<link rel="stylesheet" href="//cdn.datatables.net/1.10.13/css/jquery.dataTables.min.css" type="text/css">
<script src="//cdn.datatables.net/1.10.13/js/jquery.dataTables.min.js"></script>
    
</head>
<body>
<?php
$fields=array("FirstName", "LastName", "DOB", "CNP");
foreach($fields as $field){
    echo '<strong>'.$field.'</strong>: '.$person->$field.'<br />';
}
?>

<div class="container">
<table class="table table-striped" id="myTable">
    <thead>
        <tr>
            <th>ID</th>
            <th>ISCED</th>
            <th>School name</th>
            <th>Started</th>
            <th>Finished</th>
            <th>Is completed?</th>
            <th>Finish GPA</th>
            <th>Exam GPA</th>
        </tr>
    </thead>
    <tbody>
<?php

foreach($studies as $study){
    ?>
        <tr>
            <td><?php echo $study->ID; ?></td>
            <td><?php echo $study->StudyLevel; ?></td>
            <td><?php echo $study->SchoolName; ?></td>
            <td><?php echo $study->DateStarted; ?></td>
            <td><?php echo $study->DateCompleted; ?></td>
            <td><?php echo $study->IsCompleted; ?></td>
            <?php if($study->IsCompleted){
                ?>
            <td><?php echo $study->FinishGPA; ?></td>
            <td><?php echo $study->ExamGPA; ?></td>            
                <?php
            } else {
                ?>
            <td>-</td>
            <td>-</td>            
                <?php                
            } ?>
        </tr>
    <?php
}

?>
    </tbody>
    <tfoot>
        <tr>
            <th>ID</th>
            <th>ISCED</th>
            <th>School name</th>
            <th>Started</th>
            <th>Finished</th>
            <th>Is completed?</th>
            <th>Finish GPA</th>
            <th>Exam GPA</th>
        </tr>
    </tfoot>
</table>
    
</div>


<script type="text/javascript">
$(document).ready(function(){
    $('#myTable').DataTable();
});
</script>
</body>
</html>